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
    
            if(num==1){change(1,res[6])}

        },

        error: function(res){
            console.log(res);
        }
    });
}

function change(num,last){
    
    $('.pages').html('');
    for(j=num; j<num+10; j++){
        $('.pages').append('<button onclick="page('+j+')">'+j+'</button>');
        
        if(j==last){
            let lback = num-10;
            $('.pages').prepend('<button onclick=change('+lback+','+last+')>...</button>');
            return;
        }
    }
    let to = num+10;
    $('.pages').append('<button onclick=change('+to+','+last+')>...</button>');

    if(num != 1){
        let back = num-10;
        $('.pages').prepend('<button onclick=change('+back+','+last+')>...</button>');
    }
}