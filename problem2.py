def check_palindrome(word):
    size = len(word)
    start = 0
    end = size-1
    while start < end:
        if word[start] != word[end]:
            return False
        start += 1
        end -= 1
    return True

word = 'nitin'
word2 = 'atul'
word3 = 'ashhsa'
print (check_palindrome(word))
print(check_palindrome(word2))
print (check_palindrome(word3))