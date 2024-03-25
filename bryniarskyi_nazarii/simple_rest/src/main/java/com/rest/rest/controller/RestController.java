package com.rest.rest.controller;


import com.rest.rest.dto.MapRequest;
import com.rest.rest.dto.MessageResponse;
import com.rest.rest.util.Messages;
import org.springframework.web.bind.annotation.*;

import java.util.Map;

@org.springframework.web.bind.annotation.RestController
public class RestController {

    @GetMapping("/")
    public String ddd() {
        return "Hello world";
    }

    @PostMapping("/post")
    public MessageResponse testPostBody(@RequestBody MapRequest name) {
        return new MessageResponse("Hello " + name.getName());
    }

    @PostMapping("/post-header")
    public MessageResponse testPostHeader(@RequestHeader(defaultValue = Messages.WORLD) String name) {
        return new MessageResponse("Hello " + name);
    }

    @PostMapping("/post-param")
    public MessageResponse testPostParam(@RequestParam(defaultValue = Messages.WORLD) String name) {
        return new MessageResponse("Hello " + name);
    }
}
