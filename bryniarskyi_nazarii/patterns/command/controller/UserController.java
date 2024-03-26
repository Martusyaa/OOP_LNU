package org.example.command.controller;


import org.example.command.model.entity.User;
import org.example.command.model.dto.UserRequest;
import org.example.command.service.UserService;

public class UserController {

    private UserService userServiceImpl;


    public User saveUser(final UserRequest request) {
        return userServiceImpl.save(request);
    }

    public Iterable<User> getAllUsers() {
        return userServiceImpl.findALl();
    }
}
