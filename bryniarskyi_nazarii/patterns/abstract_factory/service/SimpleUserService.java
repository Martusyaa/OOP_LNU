package org.example.abstract_factory.service;

import org.example.abstract_factory.util.UserType;


public class SimpleUserService extends UserService {

    public SimpleUserService() {
        super(UserType.SIMPLE_USER);
    }
}
