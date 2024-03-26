package org.example.command.service;

import org.example.command.model.dto.UserRequest;
import org.example.command.model.entity.User;


public interface UserService {

    User save(final UserRequest request);

    Iterable<User> findALl();
}
