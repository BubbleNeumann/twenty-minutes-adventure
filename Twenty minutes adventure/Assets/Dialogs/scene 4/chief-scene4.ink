INCLUDE ../globals.ink

{thief_catched:->third}
{not chief_visited:
    ->first
  - else:
    ->second
}



===first===

* [Поздороваться.]
- 'Добрый день, офицер. Докладывайте.'#speaker:начальник
- 'Заведено уголовное дело об убийстве, мотив - кража. Убийца - предположительно молодой мужчина, вот его фоторобот.'#speaker:вы
- 'Свидетельница утверждала, что видела, как он выпрыгнул из окна со свертком в руках и сел в машину. Мы объявили план-перехват, сейчас эту машину ищут по всему городу. На выездах поставили посты и проверяем всех, подходящих под описание.'
- 'Причину смерти жертвы установили?'#speaker:начальник
-'Предположительно, черепно-мозговая травма от удара об угол стола. Точнее скажу, после экспертизы.'#speaker:вы
- 'Понятно. Выяснили, что было украдено?'#speaker:начальник
- 'Да, старинный меч, жертва хотела продать его на аукционе на следующей неделе.'#speaker:вы
- 'Значит так, подключайте ДПС и проверяйте камеры около магазинов и заправок.'#speaker:начальник
- 'Понял. Я могу идти?'#speaker:вы
- 'Идите, офицер.'#speaker:начальник

~chief_visited = true
    -> END

===second===
'идите занимайтесь делом, офицер.'#speaker:начальник
->END

===third===
'Начинайте допрос, офицер.'#speaker:начальник
->END