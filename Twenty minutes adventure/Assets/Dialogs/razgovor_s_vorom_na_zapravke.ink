INCLUDE globals.ink

->main

===main===
~thief_catched = true
'В чем дело? Вы не имеете право меня задерживать!!!'  #speaker:Дорей Лейбинг #portrait:maincharacter
* [Спокойно] -> composure
* [Гневно] -> rage
* [Грубо] -> impoliteness

===composure===
'Мистер Лейбинг, вы задержаны по подозрению в краже и убийстве человека.'#speaker:Вы #portrait:maincharacter
'Что? Я ничего не скажу! '#speaker:Дорей Лейбинг #portrait:maincharacter
'Вы имеете право хранить молчание. Но если будете сотрудничать со следствием, то можете сократить себе срок.'#speaker:Вы #portrait:maincharacter
'Я могу подумать?' #speaker:Дорей Лейбинг #portrait:maincharacter
'Сейчас мы проедем с вами в отдел, у вас пока есть время.' #speaker:Вы #portrait:maincharacter

Вы с задержанным поехали в участок. #portrait:default
->DONE

===rage===
'Мистер Лейбинг, мы знаем, что это вы убили девушку и украли старинный меч!'#speaker:Вы #portrait:maincharacter
'Какое убийство! Вы меня с кем-то перепутали! Я ничего не делал! Я просто хотел получить свои деньги!' #speaker:Дорей Лейбинг #portrait:maincharacter
'Вот вы и признались! Кто заказчик убийства? ' #speaker:Вы #portrait:maincharacter
'Да какой заказчик?!? Я ничего не знаю! Ничего вам не скажу! Вы арестовали невиновного! Без адвоката даже не приходите ко мне!' #speaker:Дорей Лейбинг #portrait:maincharacter
'Ясно, уводите его.' #speaker:Вы #portrait:maincharacter

Вы подумали, что Лейбинг просто отнекивается, и поехали в участок. #portrait:default

->DONE

===impoliteness===
'Вы арестованы! В машину его.'#speaker:Вы #portrait:maincharacter
'Что?! Это не я! Позовите адвоката! Вы не имеете права!' #speaker:Дорей Лейбинг #portrait:maincharacter
'Вот ордер на твой арест! Можешь молчать, все равно всё узнаем! ' #speaker:Вы #portrait:maincharacter

Вы посадили преступника в машину и поехали в отдел. #portrait:default
->DONE

    -> END