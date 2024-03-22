import model.Coin;
import service.Bank;
import service.PiggyBank;
import util.Currency;

public class Main {

    public static void main(String[] args) {
        Bank<Coin> bank = new PiggyBank();

        bank.put(new Coin(1, Currency.DOLLAR));
        bank.put(new Coin(2, Currency.DOLLAR));
        bank.put(new Coin(100, Currency.UAH));
        bank.put(new Coin(5, Currency.DOLLAR));
        bank.put(new Coin(50, Currency.UAH));
        bank.put(new Coin(10, Currency.EURO));
        bank.put(new Coin(20, Currency.EURO));

        bank.printMoneyList();
    }
}
