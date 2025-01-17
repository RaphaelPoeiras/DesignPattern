﻿namespace DesignPatterns.Behavioral.Mediator
{
    public interface FacebookGroupMediator
    {
        void RegisterUser(User user);
        void SendMessage(string msg, User user);
    }
}