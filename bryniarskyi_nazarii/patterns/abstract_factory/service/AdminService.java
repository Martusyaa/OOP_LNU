package org.example.abstract_factory.service;

import org.example.abstract_factory.util.UserType;


public class AdminService extends UserService {

    public AdminService() {
        super(UserType.ADMIN);
    }
}
