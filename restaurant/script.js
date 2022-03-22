//creating a new div element
let div = document.createElement('div');

//Using this part of the code we can assign a class to the created
//div elemetn
div.className = 'className';

// creating a new h2 element and adding it to the div we created
//above
let h2 = document.createElement('h2');
h2.textContent = 'This is the text that will show up inside the h2';

//Assigning a class to the created element
h2.className = 'h2ClassName';

//Appending the element in the created div
div.appendChild(h2);

//Appending the div element to the doccument
document.body.appendChild(div);

//Anything that we want to add to the created div should always be
//before we append the said div into the body of the document