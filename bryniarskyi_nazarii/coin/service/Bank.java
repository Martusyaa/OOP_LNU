package service;

import model.Coin;

import java.util.List;


public interface Bank<T> {

    void printMoneyList();

    T put(T t);
}
