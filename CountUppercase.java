import java.io.IOException;

public class CountUppercase {
    public static void main(String[] args) throws IOException {
        String sentence = "In 2020 I would like to run ALL languages in one VM.";
        long total = 0, start = System.currentTimeMillis(), last = start;
        char[] chars = sentence.toCharArray();
        for (int i = 1; i < 10_000_000; i++) {
            for (int j = 0; j < chars.length; j++) {
                char c = chars[j];
                if (c >= 65 && c <= 90) {
                    total++;
                }
            }
//            total += sentence.chars().filter(Character::isUpperCase).count();
            if (i % 1_000_000 == 0) {
                long now = System.currentTimeMillis();
                System.out.printf("%d (%d ms)%n", i / 1_000_000, now - last);
                last = now;
            }
        }
        System.out.printf("total: %d (%d ms)%n", total, System.currentTimeMillis() - start);
        System.in.read();
    }
}