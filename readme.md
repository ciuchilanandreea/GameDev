## Prototip Initial
 >Utilizatorul poate interactiona cu caracterul, miscare in 2d, poate folosi o arma placeholder pentru a lansa proiectile. In viitor vor exista multiple arme, care, probabil vor implementa o interfata/clasa abstracta weapon cu unele functii de baza.

 >Arena si playerul au hitboxuri(collidere) care pot fi scriptate sa interactioneze la coliziune. In viitor, proiectilele vor fi distruse la contact cu arena sau cu inamicii, caz in care si inamicii vor fi distrusi/lua damage.

 >Inamicii sunt GameObjects care in momentul de fata doar lanseaza proiectile si se misca odata cu playerul. In jocul final, se vor misca automat catre pozitia playerului iar cu ajutorul hitboxurilor vom face ca daca inamicii ating playerul jocul sa se incheie.