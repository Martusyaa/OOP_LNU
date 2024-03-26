package org.example.command.model.dto;

import org.example.command.model.entity.User;
import org.example.command.model.entity.UserInfo;

public class UserRequest {

    private final User user;
    private final UserInfo info;


    public UserRequest(final String username,
                       final String name) {
        this.user = new User(username);
        this.info = new UserInfo(name);
    }

    public User getUser() {
        return user;
    }

    public UserInfo getInfo() {
        return info;
    }
}
