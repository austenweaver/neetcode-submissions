class Solution {
    /**
     * @param {character[][]} board
     * @return {boolean}
     */
    isValidSudoku(board) {

        // Rows
        for (let i = 0; i < 9; i++) {
            
            let contents = new Set();

            for (let j = 0; j < 9; j++) {

                if (contents.has(board[i][j])) {
                    return false
                }    
                else if (board[i][j] !== '.') {
                    contents.add(board[i][j])
                }

            }

        }

        // Cols
        for (let i = 0; i < 9; i++) {
            
            let contents = new Set();

            for (let j = 0; j < 9; j++) {

                if (contents.has(board[j][i])) {
                    return false
                }    
                else if (board[j][i] !== '.') {
                    contents.add(board[j][i])
                }

            }

        }

        // Squares
        for (let i = 0; i < 3; i++) {
            
            for (let j = 0; j < 3; j++) {

                let contents = new Set();

                for (let k = 0; k < 3; k++) {

                    for (let l = 0; l < 3; l++) {

                        if (contents.has(board[i*3 + k][j*3 + l])) {
                            return false
                        }    
                        else if (board[i*3 + k][j*3 + l] !== '.') {
                            contents.add(board[i*3 + k][j*3 + l])
                        }

                    }

                }

            }

        }

        return true;

    }
}
