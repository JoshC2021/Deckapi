using RestSharp;

namespace CardDemo.Models
{
    public class CardDAL
    {
        public Deck CreateDeck()
        {
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            var request = new RestRequest();
            var response = client.GetAsync<Deck>(request);
            Deck d = response.Result;
            return d;
        }

        public Deck ShuffleDeck(string deckId)
        {
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/{deckId}/shuffle/");
            var request = new RestRequest();
            var response = client.GetAsync<Deck>(request);
            Deck e = response.Result;
            return e;
        }

        public CardSet DrawCards(string deckId, int count)
        {
            var client = new RestClient($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={count}");
            var request = new RestRequest();
            var response = client.GetAsync<CardSet>(request);
            CardSet d = response.Result;
            return d;
        }
    }
}
