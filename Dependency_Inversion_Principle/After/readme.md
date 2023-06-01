```mermaid
graph TD;
    App-->Services;
    App-->EmailFactory;
    EmailFactory-->EmailSender;
    EmailFactory-->Abstraction;
    EmailSender-->Abstraction;
    Services-->Abstraction;
```