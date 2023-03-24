let fincode=["7KKU8PM","QW23RFV","123ABCD","5JH42ZS","8TYB1FD"];
let regexFIN=new RegExp("[A-Z0-9]{7}");
let finData;
let userfound=false;
finData=window.prompt("Enter fincode!");
do{
    if(regex.test(finData)){
        for (let index = 0; index < fincode.length; index++) {
           if(fincode[index]==finData && userfound==true){
            window.alert("userfound:" +index);
            break;
           }
        }
    }
    if(!userfound){
        finData=window.prompt("user not found");
      }
      else{
        finData=window.prompt("format is wrong");
      }
}
while(!regex.test(finData) || !userfound);