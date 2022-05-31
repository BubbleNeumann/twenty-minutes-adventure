INCLUDE ../globals.ink

{not oficer_greated:
    ->main
  - else:
    ->second
}
=== main ===
~oficer_greated = true
Вы зашли в участок и подошли к дежурному#speaker:... #portrait:default
* [Поговорить с дежурным] 
-> dialogue
* [Просто поздороваться и быстро уйти] -> greeting


===dialogue===
'Добрый день, офицер Кэмбел.'#speaker:Дежурный #portrait:on-duty-dude
'Здравствуй, Брукс. Не особо он добрый...'#speaker:Вы #portrait:default
'У вас все в нормально?'#speaker:Дежурный #portrait:on-duty-dude
* [Пожаловаться, что Вызвали в Выходной]->weekend
* [Сказать, что всё хорошо]
--'Да, все в порядке, просто устал... Еще и вор этот странный...'#speaker:Вы #portrait:default
- 'Почему странный? Вы Выяснили, что там произошло?'#speaker:Дежурный #portrait:on-duty-dude
* [Рассказать про преступление] -> crime
* [Сказать, что нужно сначала доложить начальству]
-- 'Мне нужно сначала доложить шефу. Он сейчас у себя?'#speaker:Вы #portrait:default
 'Да, у него только что должно было закончиться совещание.'#speaker:Дежурный #portrait:on-duty-dude
- 'Ох.. Надеюсь, он не в плохом настроении... '#speaker:Вы #portrait:default
- 'Если ему его не испортили... Давайте, удачи...'#speaker:Дежурный #portrait:on-duty-dude
- 'Спасибо'#speaker:Вы #portrait:default
Вы пошли к начальству#speaker:... #portrait:default
->END


===greeting===
'Здравствуйте, офицер Кэмбел. Вы к шефу?'#speaker:Дежурный #portrait:on-duty-dude
'Добрый день, да, я спешу. '#speaker:Вы
Вы быстро прошли мимо дежурного и пошли в кабинет начальника#speaker:...
->END


===weekend===
'Представляешь, в единственный Выходной Вызвали, даже за пончиками зайти не успел! Что за несправедливость?'#speaker:Вы #portrait:default
-'Даа... Но больше не было свободных офицеров. И шеф приказал Вызвать тебя.'#speaker:Дежурный #portrait:on-duty-dude
-'Понимаю. Так, мне ещё надо доложить начальству. Шеф у себя?'#speaker:Вы #portrait:default
- 'Да, он никуда не собирался. '#speaker:Дежурный
- 'Ладно, я пошел. Бывай.'#speaker:Вы #portrait:default
  'Давай.'#speaker:Дежурный #portrait:on-duty-dude
->END

===crime===
*'Мне кажется странным, то, что вор залез в квартиру, когда там была хозяйка... Почему он просто не мог подождать, когда она уйдет?'#speaker:Вы #portrait:default
-'Может он как-то связан с ней?'#speaker:Дежурный #portrait:on-duty-dude
- 'Вряд ли, она девушка моего напарника... Он сказал, что она никого не ждала.'#speaker:Вы #portrait:default
- 'Мдаа... Тебе пора к начальству, он просил, чтобы ты как пришел, так сразу к нему на доклад.'#speaker:Дежурный #portrait:on-duty-dude
- 'Понял, я как раз к нему и собирался.'#speaker:Вы #portrait:default

Вы кивнули дежурному и прошли к начальнику.#speaker:... #portrait:default
-> END


===second===
Хватит тратить время на разговоры, Вы должны отчитаться начальству.#speaker:... #portrait:default
->END









