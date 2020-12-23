# @author wangjinzhao on 2020/12/23
import time

sentence = "In 2020 I would like to run ALL languages in one VM."
total = 0
start = time.time()
last = start
for i in range(1, 10_000_000):
    total += len(list(filter(lambda p: p.isupper(), sentence)))
    if i % 1_000_000 == 0:
        now = time.time()
        print(f"{i / 1_000_000} ({now - last} ms)")
        last = now
print(f"total: {total} ({time.time() - start} ms)")
