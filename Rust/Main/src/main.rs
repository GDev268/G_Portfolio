fn main() {
    //Borrowing and Ownership

    let mut num1:Vec<i32> = Vec::new();
    num1 = vectorLol(num1);
    println!("{}",num1[0]);
}



fn vectorLol(mut num:Vec<i32>) -> Vec<i32> {
    num.push(1);

    return num;
}