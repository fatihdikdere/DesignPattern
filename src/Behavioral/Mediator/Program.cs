using Mediator;

IChatRoomMediator chatRoom = new ChatRoom();

User user1 = new ChatUser("user1", chatRoom);
User user2 = new ChatUser("user2", chatRoom);
User user3 = new ChatUser("user3", chatRoom);

chatRoom.RegisterUser(user1);
chatRoom.RegisterUser(user2);
chatRoom.RegisterUser(user3);

user1.Send("hello my friends");
user3.Send("hi");
user2.Send("helllo");

Console.ReadKey();