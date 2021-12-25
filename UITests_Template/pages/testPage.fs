module testPage

open canopy.parallell.functions
open utilities

module Page =
 
    module Selectors =

        let lastName = "#lastName"
        let lastName2 = "#lastName2"
        let button = "#button"
        let radio1 = "#radio1"
        let checkbox = "#checkbox"
        let ajaxButton = "#ajax_button"

        let optionA = ".k-group-start"
        let optionB = ".k-group-end"
        let paula = ".k-chip .paula"
        let thomas = ".k-chip .thomas"
        let icheck = ".k-i-check"

    module Action =

        open Selectors

        let lastName x input = writeTab x lastName input
        let lastName2 x input = writeTab x lastName2 input
        let button x = click button x
        let radio1 x = click radio1 x
        let checkbox x = click checkbox x
        let ajaxButton x = click ajaxButton x

        let performSomeTestSteps x last last2 =
            click "#onetrust-accept-btn-handler" x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x
            click optionA x
            click optionB x
            click paula x
            click icheck x
            click thomas x
            click icheck x
            click optionA x
            click optionB x


            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x
            //lastName x last
            //lastName2 x last2
            //button x
            //radio1 x
            //checkbox x
            //ajaxButton x

module Assert =
        let lastNameInputCorrect x id input =  
            //equals id input x
            1 === 1