INCLUDE globals.ink

{not criminalist_told:
    ->main
  - else:
    ->second
}

===main===
~criminalist_told = true
'Офицер Кэмбел. Есть информация по подозреваемому...' #speaker:Криминалист  #portrait:criminalist
- 'Вы его нашли?' #speaker:Вы #portrait:default
'Да, мы подключились к камерам дорожного видеонаблюдения. Похожая машина засветилась на дороге из города, только что въехала на заправку.' #speaker:Криминалист  #portrait:criminalist
'Отлично. Вызывай наряд. У нас есть минут 10, чтобы перехватить его.' #speaker:Вы #portrait:default
'Сообщить ближайшему патрулю?' #speaker:Криминалист  #portrait:criminalist
'Да, сообщайте.' #speaker:Вы #portrait:default
Вы быстро вышли из здания и поехали на заправку на выезде из города. #portrait:default
    -> END
    
    
===second===
{thief_was_interrogated: ->third}
{cups_investigated:
  'Я скоро закончу с анализом отпечатков с чашек. Вам лучше не ждать и поехать за подозреваемым.'#speaker:Криминалист  #portrait:criminalist
  -else:
  'Мне больше нечего сказать вам, офицер.'#speaker:Криминалист  #portrait:criminalist
}
->END

===third===
{criminalist_told2:
    ->forth
}
~criminalist_told2 = true
Вы вышли в коридор и посмотрели на криминалиста. #portrait:default
'Офицер Кэмбел, готовы результаты экспертизы. Посмотрите?' #speaker:Криминалист #portrait:criminalist
*[Посмотреть]-> see #speaker:Вы #portrait:default
*[Сказать, что всё и так понятно] -> dontSee


===see===
~prints_important = true
'Отлично, сейчас посмотрим. Так, отпечатки жертвы... отпечатки Себастиана?! Тут точно нет ошибки?' #speaker:Вы #portrait:default
'Точно. Мы несколько раз проверили.' #speaker:Криминалист #portrait:maincharacter
'Очень странно, я помню ,что он не прикасался к чашкам, когда мы осматривали квартиру... Значит, он был с жертвой во время убийства...' #speaker:Вы #portrait:default
'Я видел, что офицер Боровски недавно пришел в участок. Думаю, вам лучше сначала поговорить с ним, прежде чем делать какие-то выводы.' #speaker:Криминалист  #portrait:criminalist
'Да, вы правы, так и сделаю.' #speaker:Вы  #portrait:default

Вы заглянули обратно в кабинет, сказали увести задержанного и пошли искать напарника. #portrait:default
->DONE

===dontSee===
~prints_not_important = true
'Да, давайте, я приложу эту папку к делу. Всё равно и так всё ясно.' #speaker:Вы #portrait:default
'Хорошо... Задержанный во всём сознался?'  #speaker:Криминалист  #portrait:criminalist
'Почти... Я думаю, он её убил случайно и потом испугался.' #speaker:Вы #portrait:default
'Получается дело закрыто?' #speaker:Криминалист  #portrait:criminalist
'Да. Преступник найден.' #speaker:Вы #portrait:default
Вы зашли обратно в кабинет и сказали увести задержанного. #portrait:default
->END

===forth===
'Мне больше нечего вам сказать.'
->END