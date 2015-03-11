#pragma strict

var animator : Animator; //stores the animator component
var v : float; //vertical movements
var h : float; //horizontal movements
var sprint : float;
 
function Start () {
 
animator = GetComponent(Animator); //assigns Animator component when we start the game
 
}
 
function Update () {
 
v = Input.GetAxis("Vertical");
h = Input.GetAxis("Horizontal"); 
}
 
function FixedUpdate () {
 
//set the "Walk" parameter to the v axis value
animator.SetFloat ("Walk", v);

 }

