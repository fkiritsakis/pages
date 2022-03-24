//NOT WORKING YET
//See this for help https://stackoverflow.com/questions/23331546/how-to-use-javascript-to-read-local-text-file-and-read-line-by-line

//Reading from a file that is saved with the id filename in the html document
document.getElementById('file').onchange = function()
{
    var file = this.files[0];

    var reader = new FileReader();
    reader.onload = function(progressEvent)
    {
        var lines = this.result.split('\n');
        for(var line = 0; line < lines.length; line++)
        {
            //Here goes the code to create a new div element
            //Fill said code with the data from the lines that the program
            //reads from the file(Format of file: One line is product name, next
            //line is product price with two decimals)
            
            let div = document.createElement('div');

            div.className = 'divClassName';

            //creating two h2 elements to show name and price of product
            let productName = document.createElement('h2');
            let productPrice = document.createElement('h2');

            productName.textContent = 'This is the text that will show the name of the product';
            productPrice.textContent = 'This is the text that represents the price of the document';

            productName.className = 'productNameClass';
            productPrice.className = 'productPriceClass';

            div.appendChild(productName);
            div.appendChild(productPrice);

            document.body.appendChild(div);

        }

        alert('It works this far');
    }
}


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

//TBD add an onload function to the body element in the html function
//In said onload function in javascript we should read the file line by line
//and then store each line to a temporary variable and display the data accordingly
//by appending html elements 