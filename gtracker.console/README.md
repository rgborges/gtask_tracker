# Task Tracking App

## Examples

``` bash
gtask >> init
```

bash: task has been initiated with file 0908202.md

``` bash
gtask >> --new-task "Desenvolvimento de novo perfil"
```

bash: task created with id ASNDO24923492348023948

``` bash
gtask >> --set-task "ASNDO24923492348023948"
```

bash: selected task ASNDO24923492348023948

``` bash
gtask@ASNDO24923492348023948 >> log
```

Open a buffer:

``` text
Seguimos nas definições de fontes de dados, estilos de fontes e cores.
```

Result:

## 0908202.md

### Statuslog 09-08-2022 by author Rafae Borges Batista

#### Desenvolvimento de Perfil

**09-08-2022 12:09:** Seguimos nas definições de fontes de dados, estilos de fontes e cores.

## Configuration File appsettings.json

``` json
{
    "documentRender" : "markdown",
    "documentDirectoryOutput" : "working_directory",
    "dataDirectory" : "C:\\temp\\"
}
```