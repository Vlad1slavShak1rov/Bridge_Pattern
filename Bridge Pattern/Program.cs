using Bridge_Pattern;

Email email = new Email();
SMS sms = new SMS();

SenderMessages TXT_sender = new TXTSender(sms);
SenderMessages HTML_sender = new HTMLSender(email);

TXT_sender.Send();
HTML_sender.Send();