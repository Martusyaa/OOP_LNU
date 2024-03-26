package org.example.command.service;


import org.example.command.dao.UserInfoJpaRepo;
import org.example.command.dao.UserJpaRepo;
import org.example.command.model.dto.UserRequest;
import org.example.command.model.entity.User;
import org.example.command.model.entity.UserInfo;

public class UserServiceImpl implements UserService {

    private UserJpaRepo userJpaRepo;
    private UserInfoJpaRepo userInfoJpaRepo;


    @Override
    public User save(final UserRequest request) {
        final User user = request.getUser();
        final UserInfo userInfo = request.getInfo();

        userJpaRepo.save(user);
        userInfoJpaRepo.save(userInfo);

        return user;
    }

    @Override
    public Iterable<User> findALl() {
        return userJpaRepo.findAll();
    }
}
