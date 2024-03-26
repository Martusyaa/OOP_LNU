package org.example.composite;

import org.example.composite.animals.BrownCat;
import org.example.composite.animals.Cat;
import org.example.composite.animals.Dog;

import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
        Shelter animals = new Shelter(new ArrayList<>(List.of(new Cat(), new Dog())));

        animals.voice();
        animals.addAnimal(new BrownCat());

        System.out.println();

        animals.voice();
    }
}
