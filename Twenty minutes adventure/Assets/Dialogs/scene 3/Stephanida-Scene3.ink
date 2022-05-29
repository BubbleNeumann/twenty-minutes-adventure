INCLUDE ../globals.ink

-> main

=== main ===
'Здравствуйте, это вы вызвали полицию?' #speaker:Вы #portrait:default
'Ох, да, я.' #speaker:Стефанида #portrait:oldwoman
*[по делу.]
--'Пройдемте на улицу, расскажете, как все произошло.'#speaker:Вы #portrait:default
*[вежливо.]
--'Я бы хотел задать вам несколько вопросов по поводу произошедшего... Мы можем поговорить?'#speaker:Вы #portrait:default
-'Хорошо'#speaker:Стефанида #portrait:oldwoman
~started_conversation_Stepanida = true
...
    -> END
