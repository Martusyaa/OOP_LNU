package org.example.composite;

import org.example.composite.animals.Animal;

import java.util.List;

public class Shelter implements Animal {

    private final List<Animal> animalList;

    public Shelter(List<Animal> animalList) {
        this.animalList = animalList;
    }

    @Override
    public void voice() {
        for (Animal animal : animalList) {
            animal.voice();
        }
    }

    public void addAnimal(Animal animal) {
        animalList.add(animal);
    }
}
