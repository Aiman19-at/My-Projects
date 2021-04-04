let navbar = $(".navbar");

$(window).scroll(function(){
//for the sticky navbar first find the window height
//then use the height of section-2

let otop=$(".section-2").offset().top-window.innerHeight;
if($(window).scrollTop()>otop){
    navbar.addClass("sticky");
}else{
    navbar.removeClass("sticky");
}

});
//counter animation
let nCount=function(selector){
    $(this).animate({
        Counter: $(this).text()
    },{
        duration:4000,
        easing:"swing",
        step:function(value){
            $(this).text(Math.cell(value));
        }

    });
};
let a=0;
$(window).scroll(function(){
    let otop= $(".numbers").offset().top-window.innerHeight;
    if(a==0 && $(window).scrollTop()>=otop){
        a++;
        nCount(".rect>h1");
    }
})