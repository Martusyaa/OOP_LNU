package org.example.command.dao;

import org.example.command.model.entity.User;

public interface UserJpaRepo {

    User save(final User user);

    Iterable<User> findAll();
}
