package com.rest.rest.dto;

import com.rest.rest.util.Messages;

import java.util.HashMap;
import java.util.Map;

public class MapRequest {

    public String name;


    public MapRequest(String name) {

        this.name = name;
    }

    public MapRequest() {
    }

    public String getName() {
        return name;
    }


    public void  setName(String name){
        this.name=name;
    }
}
