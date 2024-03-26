package org.example.abstract_factory.controller;


import org.example.abstract_factory.model.Admin;
import org.example.abstract_factory.service.AdminService;
import org.example.abstract_factory.service.UserService;

public class AdminController {

    private final UserService userService = new AdminService();


    public Iterable<String> listOfPrivileges(final Admin admin) {
        return userService.getPrivileges().listOfPrivileges(admin);
    }
}
