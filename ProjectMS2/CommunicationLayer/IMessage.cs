﻿using System;



namespace ProjectMS2.CommunicationLayer

{
    public interface IMessage
    {
        Guid Id { get; }
        string UserName { get; }
        DateTime Date { get; }
        string MessageContent { get; }
        string GroupID { get; }
        string ToString();
    }
}