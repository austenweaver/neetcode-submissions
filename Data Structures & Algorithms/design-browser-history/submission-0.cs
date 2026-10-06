public class BrowserHistory {

    public Page currentPage;

    public BrowserHistory(string homepage) {
        currentPage = new Page(homepage);
    }
    
    public void Visit(string url) {
        currentPage.next = new Page(url);
        currentPage.next.prev = currentPage;
        currentPage = currentPage.next;
    }
    
    public string Back(int steps) {
        while (currentPage.prev != null && steps > 0) {
            currentPage = currentPage.prev;
            steps--;
        }
        return currentPage.url;
    }
    
    public string Forward(int steps) {
        while (currentPage.next != null && steps > 0) {
            currentPage = currentPage.next;
            steps--;
        }
        return currentPage.url;
    }

    public class Page {
        public string url;
        public Page prev;
        public Page next;

        public Page(string url) {
            this.url = url;
        }
    }

}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */