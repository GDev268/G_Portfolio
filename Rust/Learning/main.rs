struct IDK {
    lol: i64,
    lols: String,
    lolf: f64,
    lolc: char,
}

fn main(){
    //Structs :)
    let _string:String = String::from("AAAAAAAAAAAAAAAAAAAAAAAAA");
    let _int: i64 = 509255256236;
    let _float: f64 = 5.2542;
    let _char: char = 'e';
    //Need to identify who is who
    let packer = IDK {lol: _int,lols: _string,lolf: _float,lolc: _char};

    println!("Struct Integer:{}\nStruct String:{}\nStruct Float:{}\nStruct char:{}",packer.lol,packer.lols,packer.lolf,packer.lolc);
}