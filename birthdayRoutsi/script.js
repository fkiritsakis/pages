var bdayDate = new Date("June 11, 2022  00:00:00"); 

const second = 1000;
const minute = second * 60;
const hour = minute * 60;
const day = hour * 24;

var refreshRate = setInterval(updateCountdown, second);

function updateCountdown()
{
    
    var now = new Date().getTime();

    var difference = bdayDate - now;
        

    document.getElementById("dayCounter").innerHTML = Math.floor(difference / day);
    document.getElementById("hourCounter").innerHTML = Math.floor(Math.floor(difference % day) / hour);
    document.getElementById("minuteCounter").innerHTML = Math.floor(Math.floor(difference % hour) / minute);
    document.getElementById("secondCounter").innerHTML = Math.floor(Math.floor(difference % minute) / second);
    
}