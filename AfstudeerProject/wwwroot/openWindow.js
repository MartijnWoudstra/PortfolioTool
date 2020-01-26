window.openWindow = {
    showPrompt1: function (text) {
        return prompt(text, '');
    },
    showPrompt2: function (text) {
        return prompt(text, '');
    },
    showPrompt3: function (text) {
        return prompt(text, '');
    },
    showPrompt4: function (text) {
        return prompt(text, '');
    },
    showPrompt5: function (text) {
        return prompt(text, '');
    },
    showPrompt6: function (text) {
        return prompt(text, '');
    },
    adjustLine: function (from, to, hard, pos) {
        var color = hard == true ? 'black' : (pos == true ? 'green' : 'red')
        $().connections({
            from: '#' + from, to: '#' + to,
            css: {
                'color': color

            },
        })
    }
};