// See https://aka.ms/new-console-template for more information

// Ici on est dans le static void main

using JeVaisAuTravail;

Afficher("Coucou");

void Afficher(string message)
{
    Console.WriteLine(message);
}

// StaticMeteo meteo = new ();

ApiMeteo meteo = new ();

Salarie salarie = new (meteo);

