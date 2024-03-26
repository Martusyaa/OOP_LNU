package org.example.command.dao;

import org.example.command.model.entity.UserInfo;


public interface UserInfoJpaRepo {

    UserInfo save(final UserInfo user);

    Iterable<UserInfo> findAll();
}
