package com.university.simple.rest.model;



public class SimpleModel {
    private String name;

    public SimpleModel(final String name) {
        this.name = name;
    }

    public SimpleModel(){}

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
