using VisitorPattern;

IMobileVisitor visitor = new Instagram();

MobilePhone mb = new IPhone("15 pro");
mb.Accept(visitor);