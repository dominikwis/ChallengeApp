using ChallengeApp;

User user1 = new User("Dominik", "qweasdzxc");
User user2 = new User("Natalia", "tyughjvbn");
User user3 = new User("Rafał", "123qwe");
User user4 = new User("Monika", "qpalzm");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;