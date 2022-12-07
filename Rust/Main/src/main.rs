fn main() {
    let mut v:Vec<i32> = vec![1,2,3,4,5];
    let mut v2:Vec<i32> = vec![0;10];

    println!("The third element on the vector is {:?}",v[2]);

    let mut shesh = v[2];

    v.push(52);

    println!("The sixth element on the vector is {:?}",v[5]);
}
