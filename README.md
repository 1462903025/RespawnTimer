# RespawnTimer

# Config
| Name | Type | Description | Default |
| --- | --- | --- | --- |
| IsEnabled | bool | Is the plugin enabled | true |
| ShowTimerOnlyOnSpawn | bool | Should a timer be only shown, when a spawnning sequence has begun? (NTF Helicopter / Chaos Car arrives) Good, if you want to keep ghosting to minimum or something | false |
| ShowTickets | bool | Should the NTF and CI respawn tickets be shown? | true
| translations | List<string> | All of the texts in this plugin. If you need to translate them, you can easily do this: (The dashed line is just a interspace. Things in { } are numeric variables, you can for example bold them. DO NOT CHANGE NAMES IN { }! | English

# Translations
Feel free to send me your translation so I can add it to the list

English (by me):
```yml
translations:
  - '<color=orange>You will respawn in: </color>'
  - 'You will spawn as: '
  - <color=blue>Nine-Tailed Fox</color>
  - <color=green>Chaos Insurgency</color>
  - '<color=blue>NTF Tickets: </color>'
  - '<color=green>CI Tickets: </color>'
  - '-------------------------------------'
  - <b>{seconds} s</b>
  - '{ntf_tickets_num}'
  - '{ci_tickets_num}'
```

Polish (by me):
```yml
translations:
  - '<color=orange>Zrespawnujesz się za: </color>'
  - 'Pojawisz się jako: '
  - <color=blue>Nine-Tailed Fox</color>
  - <color=green>Rebelia Chaosu</color>
  - '<color=blue>Bilety NTF: </color>'
  - '<color=green>Bilety Rebelli: </color>'
  - '-------------------------------------'
  - <b>{seconds} s</b>
  - '{ntf_tickets_num}'
  - '{ci_tickets_num}'
  ```
