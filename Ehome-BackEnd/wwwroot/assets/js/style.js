$('.blogcarusel').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    dots:false,
    autoplay:true,
    autoplayTimeout:5000,
    autoplayHoverPause:false,
    responsive:{
        400:{
            items:2
        },
        600:{
            items:3
        },
        1000:{
            items:4
        }
    }
})

$('.carusel').owlCarousel({
    loop:true,
    margin:10,
    nav:false,
    autoplay:true,
    autoplayTimeout:5000,
    autoplayHoverPause:false,
    responsive:{
        0:{
            items:7
        },
        600:{
            items:7
        },
        1000:{
            items:7
        }
    }
})

$('.detailcarousel').owlCarousel({
    loop:true,
    dots:false,
    margin:10,
    nav:false,
    responsiveClass:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:1
        }
    }
})

const telephone =document.querySelector(".ringphone")

telephone.addEventListener("click",function(){
    window.alert("Bizi seçdiyiniz üçün təşəkkürlər!Zəng edə bilməyiniz üçün qeydiyyatdan keçməlisiniz!");
})



let btnScrolltop = document.querySelector("#btnScrollTop")

btnScrolltop.addEventListener('click' ,function(){

    window.scrollTo({
        top:0,
        left:0,
        behavior:"smooth",
    });   
})

window.addEventListener("scroll" ,scrollFunction);

function scrollFunction(){
    if(window.scrollY>300){
        btnScrolltop.style.display="block";
    }
    else{
        btnScrolltop.style.display="none";
    }
}

$(document).ready(function () {
    $(".catlib").hide();
    $(".cat-lib").click(function (e) {
        e.preventDefault();
        $(".catli").hide();
        $(".catlim").hide();
        $(".catlib").slideToggle();
        $(".cat-li i").toggleClass("cat-li-icon")
    });

});

$(document).ready(function () {
    $(".catlil").hide();
    $(".cat-lil").click(function (e) {
        e.preventDefault();
        $(".catli").hide();
        $(".catlim").hide();
        $(".catlib").hide();
        $(".catlil").slideToggle();
        $(".cat-li i").toggleClass("cat-li-icon")
    });

});



$(document).ready(function(){
    $(".catli").hide();
    $(".cat-li").click(function(e){
        e.preventDefault();
        $(".catli").slideToggle();
        $(".cat-li i").toggleClass("cat-li-icon")   
    });
    
});

$(document).ready(function () {
    $(".catlim").hide();
    $(".cat-lim").click(function (e) {
        e.preventDefault();
        $(".catli").hide();
        $(".catlim").slideToggle();
        $(".cat-li i").toggleClass("cat-li-icon")
    });

});


const ceklim = document.querySelectorAll(".cat-lim")

ceklim.forEach(rotate => {
    rotate.addEventListener("click", () => {
        rotate.classList.toggle("active")
    });
});

const cekli= document.querySelectorAll(".cat-li")

cekli.forEach(rotate => {
    rotate.addEventListener("click",()=>{
        rotate.classList.toggle("active")
    });
});



const menu = document.querySelector(".menubar");
const menubarin = document.querySelector(".menubarin");

menu.addEventListener("click" , (e)=>{
    e.preventDefault();
    menu.classList.toggle("active");
    menubarin.classList.toggle("active");
})

$(document).ready(function(){
    $(".menubar").click(function(){
        $(".headertoptwo").toggle();
    });
});


const basketmenuhead =document.querySelector(".basketmenuhead")
const basketmenu = document.querySelector(".basketmenu")
const basketin =document.querySelector(".basketmenu-in")
const closebasket =document.querySelector(".closebasket")
const basketitem =document.querySelector(".basket-items")
const cleanproduct =document.querySelector(".productclean")


closebasket.addEventListener("click",(e)=>{
    e.preventDefault();
    basketin.classList.remove("active")
})

basketmenu.addEventListener("click",(e)=>{
    e.preventDefault();
    basketmenu.classList.toggle("active");
    basketin.classList.toggle("active")
})


basketmenuhead.addEventListener("click",(e)=>{
    e.preventDefault();
    basketmenuhead.classList.toggle("active");
    basketin.classList.toggle("active")
})

const wishlistinhead =document.querySelector(".wishlistmenuhead")
const wishlistmenu = document.querySelector(".wishlistmenu")
const wishlistin =document.querySelector(".wishlistmenu-in")
const closewishlist =document.querySelector(".closewishlist")



closewishlist.addEventListener("click",(e)=>{
    e.preventDefault();
    wishlistin.classList.remove("active")
})

wishlistmenu.addEventListener("click",(e)=>{
    e.preventDefault();
    wishlistmenu.classList.toggle("active");
    wishlistin.classList.toggle("active")
})


wishlistinhead.addEventListener("click",(e)=>{
    e.preventDefault(e);
    wishlistinhead.classList.toggle("active");
    wishlistin.classList.toggle("active")
})


const scalemenu = document.querySelector(".scalemenu")
const scalein =document.querySelector(".scalemenu-in")
const closescale =document.querySelector(".closescale")



closescale.addEventListener("click",(e)=>{
    e.preventDefault();
    scalein.classList.remove("active")
})

scalemenu.addEventListener("click",(e)=>{
    e.preventDefault();
    scalemenu.classList.toggle("active");
    scalein.classList.toggle("active")
})




  
  