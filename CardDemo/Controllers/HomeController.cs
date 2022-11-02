using CardDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace CardDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CardDAL dal = new CardDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int defaultHandSize = 5;
            Deck cards = dal.CreateDeck();
            CardSet cset = dal.DrawCards(cards.deck_id, defaultHandSize);

            return View(cset);
        }

        [HttpPost]
        public IActionResult Index(string deckId, List<Card> hand, List<int> keepList)
        {
            int newCards = 5-keepList.Count;

            // only need to draw for each card you discarded
            CardSet cset = dal.DrawCards(deckId, newCards);

            List<Card> keptCards = new List<Card>();

            // Identify which cards to keep
            foreach(int num in keepList)
            {
                keptCards.Add(hand[num]);
            }

            // Add the old hand back to the beginning
            if (keepList != null)
            {
                cset.cards.InsertRange(0, keptCards);
            }

            return View(cset);
        }

        public async Task<IActionResult> Shuffle(string deckId)
        {
            int defaultHandSize = 5;
            Deck deck = dal.ShuffleDeck(deckId);

            CardSet cset = dal.DrawCards(deck.deck_id, defaultHandSize);

            return View("Index", cset);

        }
        //Commented out non DAL HttpClient technique
        //public async Task<IActionResult> Index()
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://www.deckofcardsapi.com/");
        //    var response = await client.GetAsync("/api/deck/new/shuffle/?deck_count=1");
        //    // string result = await response.Content.ReadAsStringAsync();
        //    // ViewBag.result = result;
        //    Deck cards = await response.Content.ReadAsAsync<Deck>();

        //    response = await client.GetAsync($"/api/deck/{cards.deck_id}/draw/?count=5");
        //    CardSet cset = await response.Content.ReadAsAsync<CardSet>();

        //    return View(cset);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Index(string deckId, List<Card> hand, List<int> keepList)
        //{


        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://www.deckofcardsapi.com/");

        //    // only need to draw for each card you discarded
        //    var response = await client.GetAsync($"/api/deck/{deckId}/draw/?count={5 - keepList.Count}");
        //    CardSet cset = await response.Content.ReadAsAsync<CardSet>();

        //    List<Card> keptCards = new List<Card>();

        //    // Identify which cards to keep
        //    foreach (int num in keepList)
        //    {
                
        //        keptCards.Add(hand[num]);
        //    }

        //    // Add the old hand back
        //    if (keepList != null)
        //    {
        //        cset.cards.InsertRange(0, keptCards);
        //    }

        //    return View(cset);
        //}

        //public async Task<IActionResult> Shuffle(string deckId)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://www.deckofcardsapi.com/");

        //    // only need to draw for each card you discarded
        //    var response = await client.GetAsync($"/api/deck/{deckId}/shuffle");
        //    Deck deck = await response.Content.ReadAsAsync<Deck>();
        //    response = await client.GetAsync($"/api/deck/{deck.deck_id}/draw/?count=5");
        //    CardSet cset = await response.Content.ReadAsAsync<CardSet>();

        //    return View("Index",cset);

        //}



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
