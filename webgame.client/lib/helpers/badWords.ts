const BAD_WORDS: string[] = [
    "kurva", "pica", "píča", "kokot", "čurák", "curak", "debil", "idiot", "kretén", "kreten", "zmrd", "prdel", "hajzl", "vole", "hovado", "sračka", "sracka", "píčovina", "picovina", "zasraný", "zasrany", "zkurvit", "posrat", "doprdele", "kurwa", "čůrák", "fuck", "shit", "ass", "bitch", "dick", "cunt", "bastard", "damn", "whore", "slut", "nigger", "faggot", "retard", "nigg", "nigga", "negr"
];
export const containsBadWord = (text: string): boolean => {
    const lower = text.toLowerCase().trim();
    return BAD_WORDS.some((word) => lower.includes(word));
};