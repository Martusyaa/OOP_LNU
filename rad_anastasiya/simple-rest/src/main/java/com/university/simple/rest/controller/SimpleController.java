package com.university.simple.rest.controller;

import com.university.simple.rest.model.SimpleModel;
import org.springframework.web.bind.annotation.*;

import java.util.Objects;

@RestController
public class SimpleController {
    @GetMapping("/head")
    public @ResponseBody SimpleModel getHeader(@RequestHeader final String name) {
        if (Objects.nonNull(name)) {
            return new SimpleModel("Hello, " + name);
        }
        return new SimpleModel("Hello, World");
    }

    @GetMapping("/param")
    public @ResponseBody SimpleModel getParam(@PathVariable final String name) {
        if (Objects.nonNull(name)) {
            return new SimpleModel("Hello, " + name);
        }
        return new SimpleModel("Hello, World");
    }

    @GetMapping("/body")
    public @ResponseBody SimpleModel getBody(@RequestBody final SimpleModel name) {
        if (Objects.nonNull(name)) {
            return new SimpleModel("Hello, " + name.getName());
        }
        return new SimpleModel("Hello, World");
    }
}
