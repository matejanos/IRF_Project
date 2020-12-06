# IRF_Project
Az alkalmazásom egy olyan étterem számára készült, ahol csak ebéd menüket illetve hozzá tartozó italokat lehet kérni.
A jelenlegi covid helyzet miatt csak kiszállítás lehetséges,erre fog segítséget nyújtani az alkalmazásom.
A előre eltervezett menük, már össze vannak állítva egy XML fájlban, ezt az alkalmazás beolvassa és feldolgozza.
A kezdő oldalon egy gomb rács látható, aminek minden eleme az adott naphoz tartozó menüt jeleníti meg, linq segítségvel .
Az ebéd menüs szolgáltatást sokan csak hétköznap veszik igénybe, ezért nekik azzal segítünk, hogy a szombati napokat
kékre színezzük a vasárnapokat pedig pirosra. Ha rákattintunk egy napra akkor egy új formon megnyilik az adott napi menű.
Alapértelmezetten a cég nem szállít italt ezért ezt nekünk kell megrendelni. A mentés gomb segítségvel egy csv fájlba tudjuk
menteni a rendelés adatatit. 
