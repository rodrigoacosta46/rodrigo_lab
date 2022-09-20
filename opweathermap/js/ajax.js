function weatherdata(){
    let latitud = document.getElementById("input-1").value;
    let altitud = document.getElementById("input-2").value;


    const arreglo = [];
    const temp = [];
    /*const daily = [];*/
    const day = [];
        day[0] = 'Domingo';
        day[1] = 'Lunes';
        day[2] = 'Martes';
        day[3] = 'Miercoles';
        day[4] = 'Jueves';
        day[5] = 'Viernes';
        day[6] = 'Sabado';

    const clima = [];
        clima['Clouds'] = ' con un clima nublado';
        clima['Rain'] = ' con un clima lluvioso';
        clima['Clear'] = ' con un cielo despejado';
        clima['Snow'] = ' con un clima frio';

    /*for(i=0; i<7; i++){
        daily[i] = Array('start');
    }*/
    $.ajax({
        url: 'https://api.openweathermap.org/data/2.5/forecast?lat='+latitud+'&lon='+altitud+'&appid=2be41a993eaf59fb2c6d4e960c4a2e5f&units=metric&lang=sp',
        dataType: 'json',

        success: function(datos){
            console.log(datos);
            $('#place').html('El pronostico de '+datos['city']['name']+'&nbsp('+datos['city']['country']+')');
            $('#daily').html('Pronostico del el dia de hoy ('+day[new Date().getDay()]+')');
            $('#weekly').html('Pronostico de los dias próximos');

            $('p').html('');

            for(i=0; i<datos['list'].length; i++){
                dia = new Date(datos['list'][i]['dt_txt']).getDay();
                arreglo[i] = [datos['list'][i]['main']['temp_max'], datos['list'][i]['dt_txt'], datos['list'][i]['weather'][0]['main']];
                temp[i] = datos['list'][i]['main']['temp_max'];

                if(dia == new Date().getDay()){
                    document.getElementById('result_d').innerHTML += 'Hoy a las '+new Date(arreglo[i][1]).getHours()+' horas habrá una temperatura máxima de '+arreglo[i][0]+' grados '+clima[arreglo[i][2]]+'<br>';
                }
                else{
                    document.getElementById('result_w').innerHTML += 'El día '+day[new Date(arreglo[i][1]).getDay()]+' a las '+new Date(arreglo[i][1]).getHours()+' horas habrá una temperatura de '+arreglo[i][0]+' grados '+clima[arreglo[i][2]]+'<br>';
                }
            }
            console.log(arreglo);
            max_temp = Math.max(...temp);
            min_temp = Math.min(...temp);

            for(j=0; j<arreglo.length; j++){
                if(arreglo[j][0] == max_temp){
                    max_day = new Date(arreglo[j][1]).getDay();        
                }
                else if(arreglo[j][0] == min_temp){
                    min_day = new Date(arreglo[j][1]).getDay();
                }
            }
            
            $('#hottest').html('En el dia '+day[max_day]+' se registró la temperatura más alta: '+max_temp);
            $('#coldest').html('En el dia '+day[min_day]+' se registró la temperatura más baja: '+min_temp);
            
            /*
            for(k=0; k<arreglo.length; k++){
                switch(arreglo[k][3]){
                    case 0:
                        daily[0].push(arreglo[k][3]);
                        break;
                    case 1:
                        daily[1].push(arreglo[k]);
                        break;
                    case 2:
                        daily[2].push(arreglo[k]);
                        break;
                    case 3:
                        daily[3].push(arreglo[k]);
                        break;
                    case 4:
                        daily[4].push(arreglo[k]);
                        break;
                    case 5:
                        daily[5].push(arreglo[k]);
                        break;
                    case 6:
                        daily[6].push(arreglo[k]);
                        break;
                }
            }
            console.log(daily);

            */
        },

        error: function(){
            alert('No se encontro ubicacion geografica');
        }
    });
}
/*
var array1 = [1,5,6,2,4];
var indice = 0;
var j = 0;

for(i=0 ; i<array1.length; i++){
    console.log('indice actual primer for:'+i);
    for(k=0 ; k<array1.length ; k++){
        console.log('indice actual segundo for:'+k);
        if(array1[i] > array1[k]){
            j++;
            console.log(j);
            if(j == array1.length){
                indice = i;
            }
        }
        else if(array1[i] < array1[k]){
            i++;
            j=0;
        }
        else if(array1[i] == array1[k]){
            j++;
        }
    }
}
console.log(array1[indice]);*/