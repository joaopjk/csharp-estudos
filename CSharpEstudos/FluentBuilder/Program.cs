using FluentBuilder;

var emailBuilder = new EmailBuilder();

emailBuilder.To("microsoft@email.com");
emailBuilder.From("joao@email.com");
emailBuilder.Subject("Builder Design Patterns");
emailBuilder.Body("This is a test email using the Builder Design Pattern.");

var email = emailBuilder.Build();
Console.WriteLine(email.ToString());

var emailFluentBuilder = new EmailFluentBuilder();
var emailFluent = emailFluentBuilder
    .To("microsoft@email.com")
    .From("joao@email.com")
    .Subject("Builder Design Patterns")
    .Body("This is a test email using the Builder Design Pattern.");
Console.WriteLine(emailFluent.ToString());
