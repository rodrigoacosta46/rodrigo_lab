function page(num){    
    $.ajax({
        url: "model.php?page="+num,
        dataType: 'JSON',
        
        success: function(res){
            console.log(res);
            $('#c1').html('<div>Rango</div>');
            $('#c2').html('<div>Division</div>');
            $('#c3').html('<div>Cargo</div>');

            for(i=0; i<5; i++){
                $('#c1').append('<div>'+res[i][1]+'</div>');
                $('#c2').append('<div>'+res[i][2]+'</div>');
                $('#c3').append('<div>'+res[i][3]+'</div>');
            }
    
            if(num == 1 || (num-1)%10==0){
                $('.pages').html('');
            
                for(j=1; j<12; j++){
                    $('.pages').append('<button onclick="page('+res[6][j]+')">'+res[6][j]+'</button>');
                    
                    if(j > res[7]){
                        where = res[6][1]-4;
                        $('.pages').prepend('<button onclick="page('+where+')">...</button>');
                        break;
                    }
                }

            }
        },

        error: function(res){
            console.log(res);
        }
    });
}