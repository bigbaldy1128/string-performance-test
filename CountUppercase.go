package main

import (
    "fmt"
    "time"
)

func makeTimestamp() int64 {
    return time.Now().UnixNano() / int64(time.Millisecond)
}

func main() {
    var sentence = "In 2020 I would like to run ALL languages in one VM."
    var total = 0
    var start = makeTimestamp()
    var last = start
    for i := 1; i < 10_000_000; i++ {
        for j := 0; j < len(sentence); j++ {
            ch := sentence[j]
            if(ch >=65 && ch <= 90){
                total++
            }
        }
        if (i % 1_000_000 == 0) {
            var now = makeTimestamp()
            fmt.Printf("%d (%d ms)\n", i / 1_000_000, now - last);
            last = now;
        }
    }
    fmt.Printf("total: %d (%d ms)\n", total, makeTimestamp() - start);
    var s byte
    fmt.Scanln(&s)
}