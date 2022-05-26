->main
===main===
Вы вышли в коридор и посмотрели на криминалиста. #portrait:default
'Офицер Кэмбел, готовы результаты экспертизы. Посмотрите?' #speaker:Криминалист #portrait:maincharacter
*[Посмотреть]-> see #speaker:Вы #portrait:maincharacter
*[Сказать, что всё и так понятно] -> dontSee


===see===
'Отлично, сейчас посмотрим. Так, отпечатки жертвы... отпечатки Себастиана?! Тут точно нет ошибки?' #speaker:Вы #portrait:maincharacter
'Точно. Мы несколько раз проверили.' #speaker:Криминалист #portrait:maincharacter
'Очень странно, я помню ,что он не прикасался к чашкам, когда мы осматривали квартиру... Значит, он был с жертвой во время убийства...' #speaker:Вы #portrait:maincharacter
'Я видел, что офицер Боровски недавно пришел в участок. Думаю, вам лучше сначала поговорить с ним, прежде чем делать какие-то выводы.' #speaker:Криминалист #portrait:maincharacter
'Да, вы правы, так и сделаю.' #speaker:Вы #portrait:maincharacter

Вы заглянули обратно в кабинет, сказали увести задержанного и пошли искать напарника. #portrait:default
->DONE

===dontSee===
'Да, давайте, я приложу эту папку к делу. Всё равно и так всё ясно.' #speaker:Вы #portrait:maincharacter
'Хорошо... Задержанный во всём сознался?'  #speaker:Криминалист #portrait:maincharacter
'Почти... Я думаю, он её убил случайно и потом испугался.' #speaker:Вы #portrait:maincharacter
'Получается дело закрыто?' #speaker:Криминалист #portrait:maincharacter
'Да. Преступник найден.' #speaker:Вы #portrait:maincharacter
Вы зашли обратно в кабинет и сказали увести задержанного. #portrait:default
->DONE
    -> END
