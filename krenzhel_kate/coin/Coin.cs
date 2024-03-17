public class Coin
{
    private int coins;
    private Level symbol;

    public Coin(int coin, Level sym)
    {
        coins = coin;
        symbol = sym;
    }

    public int GetCoins()
    {
        return coins;
    }

    public string GetSymbol()
    {
        switch (symbol)
        {
            case Level.Dolar:
                return "d";
            case Level.Euro:
                return "e";
            case Level.Gryvnya:
                return "g";
            default:
                throw new ArgumentException("Unknown level", nameof(symbol));
        }
    }
    
}